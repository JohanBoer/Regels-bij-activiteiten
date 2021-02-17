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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// &lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
    /// </summary>
    [DataContract(Name = "Kop")]
    public partial class Kop : IEquatable<Kop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kop" /> class.
        /// </summary>
        /// <param name="label">label.</param>
        /// <param name="nummer">nummer.</param>
        /// <param name="opschrift">opschrift.</param>
        public Kop(string label = default(string), string nummer = default(string), string opschrift = default(string))
        {
            this.Label = label;
            this.Nummer = nummer;
            this.Opschrift = opschrift;
        }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Nummer
        /// </summary>
        [DataMember(Name = "nummer", EmitDefaultValue = false)]
        public string Nummer { get; set; }

        /// <summary>
        /// Gets or Sets Opschrift
        /// </summary>
        [DataMember(Name = "opschrift", EmitDefaultValue = false)]
        public string Opschrift { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Kop {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Nummer: ").Append(Nummer).Append("\n");
            sb.Append("  Opschrift: ").Append(Opschrift).Append("\n");
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
            return this.Equals(input as Kop);
        }

        /// <summary>
        /// Returns true if Kop instances are equal
        /// </summary>
        /// <param name="input">Instance of Kop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Kop input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Nummer == input.Nummer ||
                    (this.Nummer != null &&
                    this.Nummer.Equals(input.Nummer))
                ) && 
                (
                    this.Opschrift == input.Opschrift ||
                    (this.Opschrift != null &&
                    this.Opschrift.Equals(input.Opschrift))
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Nummer != null)
                    hashCode = hashCode * 59 + this.Nummer.GetHashCode();
                if (this.Opschrift != null)
                    hashCode = hashCode * 59 + this.Opschrift.GetHashCode();
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