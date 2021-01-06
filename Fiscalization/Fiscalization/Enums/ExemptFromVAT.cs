using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fiscalization.Enums
{
    public enum ExemptFromVAT
    {
        /// <summary> Përjashtohet në bazë të nenit 51 të ligjit të TVSH-së </summary>
        [Description("Përjashtohet në bazë të nenit 51 të ligjit të TVSH-së")]
        TYPE_1,
        /// <summary> Përjashtohet në bazë të neneve 53 dhe 54 të ligjit të TVSh-së </summary>
        [Description("Përjashtohet në bazë të neneve 53 dhe 54 të ligjit të TVSh-së")]
        TYPE_2,
        /// <summary> 
        /// Shitje pa TVSH që përjashtohen bazuar në ligjin e TVSH-së, përveç neneve 51, 53 dhe 54 të ligjit të TVSh-së, 
        /// dhe nuk është skemë e marzhit dhe as eksporti i mallrave
        /// </summary>
        [Description("Shitje pa TVSH që përjashtohen bazuar në ligjin e TVSH-së, përveç neneve 51, 53 dhe 54 të ligjit të TVSh-së, dhe nuk është skemë e marzhit dhe as eksporti i mallrave")]
        TAX_FREE,
        /// <summary> Pa TVSH për këtë artikull bazuar në rregullat e skemës së Marzhit 
        /// (skema e TVSH-së për agjentët e udhëtimit, skema e TVSH së mallrave të dorës së dytë, skemës së TVSH-së e vepratve të artit, 
        /// skema e TVSH-së e artikujve të koleksioneve dhe antike, etj.).
        /// </summary>
        [Description("Pa TVSH për këtë artikull bazuar në rregullat e skemës së Marzhit (skema e TVSH-së për agjentët e udhëtimit, skema e TVSH së mallrave të dorës së dytë, skemës së TVSH-së e vepratve të artit, skema e TVSH-së e artikujve të koleksioneve dhe antike, etj.)")]
        MARGIN_SCHEME,
        /// <summary> Nuk ka TVSh për këtë artikull bazuar në lirimin nga eksporti i rregullave të mallrave.</summary>
        [Description("Nuk ka TVSh për këtë artikull bazuar në lirimin nga eksporti i rregullave të mallrave.")]
        EXPORT_OF_GOODS,
    }
}
