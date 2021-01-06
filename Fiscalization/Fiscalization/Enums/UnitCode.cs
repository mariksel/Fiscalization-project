using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fiscalization.Enums
{
    /// <summary>
    /// https://old.asiakas.gs1.fi/en/synkka-service/instructions-for-the-synkka-data-pool/data-quality/code-lists/measurement-unit-code
    /// </summary>
    public enum UnitCode
    {
        //##### Count #####
        /// <summary> Piece: A unit of count defining the number of pieces (piece: a single item, article or exemplar).</summary>
        [Description("H87 - Piece")]
        H87,

        //##### Dimensions #####
        /// <summary> Metre: The metre is the basic unit of length in the International System of Units (SI).</summary>
        [Description("MTR - Metre")]
        MTR,

        //##### Mass #####
        /// <summary> Gram: one one-thousandth of the kilogram (1×10-3 kg).</summary>
        [Description("GRM - Gram")]
        GRM,
        /// <summary> Kilogram: a unit of mass equal to one thousand grams.</summary>
        [Description("KGM - Kilogram")]
        KGM
    }
}
