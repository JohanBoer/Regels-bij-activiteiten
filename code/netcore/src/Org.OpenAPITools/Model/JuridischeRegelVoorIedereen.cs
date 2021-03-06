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
    /// &lt;body&gt;&lt;p&gt;De beschrijving van een regel met juridische werkingskracht. Een regel betreft binnen de Omgevingswet veelal activiteiten, en/of normen en/of functies en/of beperkingengebieden.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
    /// </summary>
    [DataContract(Name = "JuridischeRegelVoorIedereen")]
    public partial class JuridischeRegelVoorIedereen : IEquatable<JuridischeRegelVoorIedereen>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JuridischeRegelVoorIedereen" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JuridischeRegelVoorIedereen() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JuridischeRegelVoorIedereen" /> class.
        /// </summary>
        /// <param name="begindatum">begindatum (required).</param>
        /// <param name="einddatum">einddatum (required).</param>
        /// <param name="idealisatie">idealisatie (required).</param>
        /// <param name="identificatie">identificatie (required).</param>
        /// <param name="locatieIdentificaties">locatieIdentificaties (required).</param>
        /// <param name="normeertActiviteiten">normeertActiviteiten.</param>
        /// <param name="omschrijving">omschrijving (required).</param>
        /// <param name="regeltekstIdentificatie">regeltekstIdentificatie (required).</param>
        /// <param name="themas">themas.</param>
        public JuridischeRegelVoorIedereen(DateTime begindatum = default(DateTime), DateTime einddatum = default(DateTime), Idealisatie idealisatie = default(Idealisatie), string identificatie = default(string), List<string> locatieIdentificaties = default(List<string>), List<ActiviteitLocatieaanduiding> normeertActiviteiten = default(List<ActiviteitLocatieaanduiding>), string omschrijving = default(string), string regeltekstIdentificatie = default(string), List<Thema> themas = default(List<Thema>))
        {
            this.Begindatum = begindatum;
            this.Einddatum = einddatum;
            // to ensure "idealisatie" is required (not null)
            this.Idealisatie = idealisatie ?? throw new ArgumentNullException("idealisatie is a required property for JuridischeRegelVoorIedereen and cannot be null");
            // to ensure "identificatie" is required (not null)
            this.Identificatie = identificatie ?? throw new ArgumentNullException("identificatie is a required property for JuridischeRegelVoorIedereen and cannot be null");
            // to ensure "locatieIdentificaties" is required (not null)
            this.LocatieIdentificaties = locatieIdentificaties ?? throw new ArgumentNullException("locatieIdentificaties is a required property for JuridischeRegelVoorIedereen and cannot be null");
            // to ensure "omschrijving" is required (not null)
            this.Omschrijving = omschrijving ?? throw new ArgumentNullException("omschrijving is a required property for JuridischeRegelVoorIedereen and cannot be null");
            // to ensure "regeltekstIdentificatie" is required (not null)
            this.RegeltekstIdentificatie = regeltekstIdentificatie ?? throw new ArgumentNullException("regeltekstIdentificatie is a required property for JuridischeRegelVoorIedereen and cannot be null");
            this.NormeertActiviteiten = normeertActiviteiten;
            this.Themas = themas;
        }

        /// <summary>
        /// Gets or Sets Begindatum
        /// </summary>
        [DataMember(Name = "begindatum", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Begindatum { get; set; }

        /// <summary>
        /// Gets or Sets Einddatum
        /// </summary>
        [DataMember(Name = "einddatum", IsRequired = true, EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Einddatum { get; set; }

        /// <summary>
        /// Gets or Sets Idealisatie
        /// </summary>
        [DataMember(Name = "idealisatie", IsRequired = true, EmitDefaultValue = false)]
        public Idealisatie Idealisatie { get; set; }

        /// <summary>
        /// Gets or Sets Identificatie
        /// </summary>
        [DataMember(Name = "identificatie", IsRequired = true, EmitDefaultValue = false)]
        public string Identificatie { get; set; }

        /// <summary>
        /// Gets or Sets LocatieIdentificaties
        /// </summary>
        [DataMember(Name = "locatieIdentificaties", IsRequired = true, EmitDefaultValue = false)]
        public List<string> LocatieIdentificaties { get; set; }

        /// <summary>
        /// Gets or Sets NormeertActiviteiten
        /// </summary>
        [DataMember(Name = "normeertActiviteiten", EmitDefaultValue = false)]
        public List<ActiviteitLocatieaanduiding> NormeertActiviteiten { get; set; }

        /// <summary>
        /// Gets or Sets Omschrijving
        /// </summary>
        [DataMember(Name = "omschrijving", IsRequired = true, EmitDefaultValue = false)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// Gets or Sets RegeltekstIdentificatie
        /// </summary>
        [DataMember(Name = "regeltekstIdentificatie", IsRequired = true, EmitDefaultValue = false)]
        public string RegeltekstIdentificatie { get; set; }

        /// <summary>
        /// Gets or Sets Themas
        /// </summary>
        [DataMember(Name = "themas", EmitDefaultValue = false)]
        public List<Thema> Themas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JuridischeRegelVoorIedereen {\n");
            sb.Append("  Begindatum: ").Append(Begindatum).Append("\n");
            sb.Append("  Einddatum: ").Append(Einddatum).Append("\n");
            sb.Append("  Idealisatie: ").Append(Idealisatie).Append("\n");
            sb.Append("  Identificatie: ").Append(Identificatie).Append("\n");
            sb.Append("  LocatieIdentificaties: ").Append(LocatieIdentificaties).Append("\n");
            sb.Append("  NormeertActiviteiten: ").Append(NormeertActiviteiten).Append("\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
            sb.Append("  RegeltekstIdentificatie: ").Append(RegeltekstIdentificatie).Append("\n");
            sb.Append("  Themas: ").Append(Themas).Append("\n");
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
            return this.Equals(input as JuridischeRegelVoorIedereen);
        }

        /// <summary>
        /// Returns true if JuridischeRegelVoorIedereen instances are equal
        /// </summary>
        /// <param name="input">Instance of JuridischeRegelVoorIedereen to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JuridischeRegelVoorIedereen input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Begindatum == input.Begindatum ||
                    (this.Begindatum != null &&
                    this.Begindatum.Equals(input.Begindatum))
                ) && 
                (
                    this.Einddatum == input.Einddatum ||
                    (this.Einddatum != null &&
                    this.Einddatum.Equals(input.Einddatum))
                ) && 
                (
                    this.Idealisatie == input.Idealisatie ||
                    (this.Idealisatie != null &&
                    this.Idealisatie.Equals(input.Idealisatie))
                ) && 
                (
                    this.Identificatie == input.Identificatie ||
                    (this.Identificatie != null &&
                    this.Identificatie.Equals(input.Identificatie))
                ) && 
                (
                    this.LocatieIdentificaties == input.LocatieIdentificaties ||
                    this.LocatieIdentificaties != null &&
                    input.LocatieIdentificaties != null &&
                    this.LocatieIdentificaties.SequenceEqual(input.LocatieIdentificaties)
                ) && 
                (
                    this.NormeertActiviteiten == input.NormeertActiviteiten ||
                    this.NormeertActiviteiten != null &&
                    input.NormeertActiviteiten != null &&
                    this.NormeertActiviteiten.SequenceEqual(input.NormeertActiviteiten)
                ) && 
                (
                    this.Omschrijving == input.Omschrijving ||
                    (this.Omschrijving != null &&
                    this.Omschrijving.Equals(input.Omschrijving))
                ) && 
                (
                    this.RegeltekstIdentificatie == input.RegeltekstIdentificatie ||
                    (this.RegeltekstIdentificatie != null &&
                    this.RegeltekstIdentificatie.Equals(input.RegeltekstIdentificatie))
                ) && 
                (
                    this.Themas == input.Themas ||
                    this.Themas != null &&
                    input.Themas != null &&
                    this.Themas.SequenceEqual(input.Themas)
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
                if (this.Begindatum != null)
                    hashCode = hashCode * 59 + this.Begindatum.GetHashCode();
                if (this.Einddatum != null)
                    hashCode = hashCode * 59 + this.Einddatum.GetHashCode();
                if (this.Idealisatie != null)
                    hashCode = hashCode * 59 + this.Idealisatie.GetHashCode();
                if (this.Identificatie != null)
                    hashCode = hashCode * 59 + this.Identificatie.GetHashCode();
                if (this.LocatieIdentificaties != null)
                    hashCode = hashCode * 59 + this.LocatieIdentificaties.GetHashCode();
                if (this.NormeertActiviteiten != null)
                    hashCode = hashCode * 59 + this.NormeertActiviteiten.GetHashCode();
                if (this.Omschrijving != null)
                    hashCode = hashCode * 59 + this.Omschrijving.GetHashCode();
                if (this.RegeltekstIdentificatie != null)
                    hashCode = hashCode * 59 + this.RegeltekstIdentificatie.GetHashCode();
                if (this.Themas != null)
                    hashCode = hashCode * 59 + this.Themas.GetHashCode();
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
