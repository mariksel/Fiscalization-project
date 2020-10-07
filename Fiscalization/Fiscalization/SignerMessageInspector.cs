using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Xml;

namespace Fiscalization
{
    public class SignerMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            request.Headers.RemoveAt(0);
            request = InterceptAndSign(request);
            return null;
        }

        private Message InterceptAndSign(Message message)
        {
            //https://adamstorr.azurewebsites.net/blog/debugging-wcf-messages-before-serialization

            // read the message into an XmlDocument as then you can work with the contents 
            // Message is a forward reading class only so once read that's it. 
            MemoryStream ms = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(ms);
            message.WriteMessage(writer);
            writer.Flush();
            ms.Position = 0;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.Load(ms);

            string xmlSOAPNotSigned = xmlDoc.OuterXml;

            var signedXML = FiscalizationSigner.SignRequest(xmlSOAPNotSigned);

            // Sign the XML as text
            //string xmlSOAPSigned = UtilFiscalization.SignXMRequest(xmlSOAPNotSigned);



            // Convert XML text to XmlDocument
            xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            xmlDoc.LoadXml(signedXML);

            // as the message is forward reading then we need to recreate it before moving on 
            ms = new MemoryStream();
            xmlDoc.Save(ms);
            ms.Position = 0;
            XmlReader reader = XmlReader.Create(ms);
            Message newMessage = Message.CreateMessage(reader, int.MaxValue, message.Version);
            newMessage.Properties.CopyProperties(message.Properties);
            message = newMessage;
            return message;
        }


    }
}
