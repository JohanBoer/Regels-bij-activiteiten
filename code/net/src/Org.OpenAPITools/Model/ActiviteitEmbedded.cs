/* 
 * Plan SW - Toepasbare regel SW
 *
 * Nog in te voorzien
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: robert.melskens@vng.nl
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ActiviteitEmbedded
    /// </summary>
    [DataContract]
    public partial class ActiviteitEmbedded :  IEquatable<ActiviteitEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActiviteitEmbedded" /> class.
        /// </summary>
        /// <param name="bijbehorendeJuridischeRegelsVoorIedereen">&lt;body&gt;&lt;p&gt;Bij een regel die een activiteit vastlegt geeft deze relatie aan om welke activiteit het gaat. De bijbehorende locatie(s) waar het om gaat is/zijn bij de activiteit zelf te vinden.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;.</param>
        public ActiviteitEmbedded(List<JuridischeRegelVoorIedereenHal> bijbehorendeJuridischeRegelsVoorIedereen = default(List<JuridischeRegelVoorIedereenHal>))
        {
            this.BijbehorendeJuridischeRegelsVoorIedereen = bijbehorendeJuridischeRegelsVoorIedereen;
        }
        
        /// <summary>
        /// &lt;body&gt;&lt;p&gt;Bij een regel die een activiteit vastlegt geeft deze relatie aan om welke activiteit het gaat. De bijbehorende locatie(s) waar het om gaat is/zijn bij de activiteit zelf te vinden.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
        /// </summary>
        /// <value>&lt;body&gt;&lt;p&gt;Bij een regel die een activiteit vastlegt geeft deze relatie aan om welke activiteit het gaat. De bijbehorende locatie(s) waar het om gaat is/zijn bij de activiteit zelf te vinden.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;</value>
        [DataMember(Name="bijbehorendeJuridischeRegelsVoorIedereen", EmitDefaultValue=false)]
        public List<JuridischeRegelVoorIedereenHal> BijbehorendeJuridischeRegelsVoorIedereen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActiviteitEmbedded {\n");
            sb.Append("  BijbehorendeJuridischeRegelsVoorIedereen: ").Append(BijbehorendeJuridischeRegelsVoorIedereen).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActiviteitEmbedded);
        }

        /// <summary>
        /// Returns true if ActiviteitEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of ActiviteitEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActiviteitEmbedded input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BijbehorendeJuridischeRegelsVoorIedereen == input.BijbehorendeJuridischeRegelsVoorIedereen ||
                    this.BijbehorendeJuridischeRegelsVoorIedereen != null &&
                    input.BijbehorendeJuridischeRegelsVoorIedereen != null &&
                    this.BijbehorendeJuridischeRegelsVoorIedereen.SequenceEqual(input.BijbehorendeJuridischeRegelsVoorIedereen)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BijbehorendeJuridischeRegelsVoorIedereen != null)
                    hashCode = hashCode * 59 + this.BijbehorendeJuridischeRegelsVoorIedereen.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

            
            yield break;
        }
    }

}
