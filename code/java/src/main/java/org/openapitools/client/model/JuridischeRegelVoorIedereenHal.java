/*
 * Plan SW - Toepasbare regel SW
 * Nog in te voorzien
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: robert.melskens@vng.nl
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.ActiviteitLocatieaanduiding;
import org.openapitools.client.model.Idealisatie;
import org.openapitools.client.model.JuridischeRegelVoorIedereen;
import org.openapitools.client.model.JuridischeRegelVoorIedereenEmbedded;
import org.openapitools.client.model.JuridischeRegelVoorIedereenHalAllOf;
import org.openapitools.client.model.JuridischeRegelVoorIedereenLinks;
import org.openapitools.client.model.Thema;

/**
 * JuridischeRegelVoorIedereenHal
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-02-10T09:19:26.366Z[Etc/UTC]")
public class JuridischeRegelVoorIedereenHal {
  public static final String SERIALIZED_NAME_BEGINDATUM = "begindatum";
  @SerializedName(SERIALIZED_NAME_BEGINDATUM)
  private LocalDate begindatum;

  public static final String SERIALIZED_NAME_EINDDATUM = "einddatum";
  @SerializedName(SERIALIZED_NAME_EINDDATUM)
  private LocalDate einddatum;

  public static final String SERIALIZED_NAME_IDEALISATIE = "idealisatie";
  @SerializedName(SERIALIZED_NAME_IDEALISATIE)
  private Idealisatie idealisatie = null;

  public static final String SERIALIZED_NAME_IDENTIFICATIE = "identificatie";
  @SerializedName(SERIALIZED_NAME_IDENTIFICATIE)
  private String identificatie;

  public static final String SERIALIZED_NAME_LOCATIE_IDENTIFICATIES = "locatieIdentificaties";
  @SerializedName(SERIALIZED_NAME_LOCATIE_IDENTIFICATIES)
  private List<String> locatieIdentificaties = new ArrayList<>();

  public static final String SERIALIZED_NAME_NORMEERT_ACTIVITEITEN = "normeertActiviteiten";
  @SerializedName(SERIALIZED_NAME_NORMEERT_ACTIVITEITEN)
  private List<ActiviteitLocatieaanduiding> normeertActiviteiten = null;

  public static final String SERIALIZED_NAME_OMSCHRIJVING = "omschrijving";
  @SerializedName(SERIALIZED_NAME_OMSCHRIJVING)
  private String omschrijving;

  public static final String SERIALIZED_NAME_REGELTEKST_IDENTIFICATIE = "regeltekstIdentificatie";
  @SerializedName(SERIALIZED_NAME_REGELTEKST_IDENTIFICATIE)
  private String regeltekstIdentificatie;

  public static final String SERIALIZED_NAME_THEMAS = "themas";
  @SerializedName(SERIALIZED_NAME_THEMAS)
  private List<Thema> themas = null;

  public static final String SERIALIZED_NAME_LINKS = "_links";
  @SerializedName(SERIALIZED_NAME_LINKS)
  private JuridischeRegelVoorIedereenLinks links;

  public static final String SERIALIZED_NAME_EMBEDDED = "_embedded";
  @SerializedName(SERIALIZED_NAME_EMBEDDED)
  private JuridischeRegelVoorIedereenEmbedded embedded;


  public JuridischeRegelVoorIedereenHal begindatum(LocalDate begindatum) {
    
    this.begindatum = begindatum;
    return this;
  }

   /**
   * Get begindatum
   * @return begindatum
  **/
  @ApiModelProperty(required = true, value = "")

  public LocalDate getBegindatum() {
    return begindatum;
  }


  public void setBegindatum(LocalDate begindatum) {
    this.begindatum = begindatum;
  }


  public JuridischeRegelVoorIedereenHal einddatum(LocalDate einddatum) {
    
    this.einddatum = einddatum;
    return this;
  }

   /**
   * Get einddatum
   * @return einddatum
  **/
  @ApiModelProperty(required = true, value = "")

  public LocalDate getEinddatum() {
    return einddatum;
  }


  public void setEinddatum(LocalDate einddatum) {
    this.einddatum = einddatum;
  }


  public JuridischeRegelVoorIedereenHal idealisatie(Idealisatie idealisatie) {
    
    this.idealisatie = idealisatie;
    return this;
  }

   /**
   * Get idealisatie
   * @return idealisatie
  **/
  @ApiModelProperty(required = true, value = "")

  public Idealisatie getIdealisatie() {
    return idealisatie;
  }


  public void setIdealisatie(Idealisatie idealisatie) {
    this.idealisatie = idealisatie;
  }


  public JuridischeRegelVoorIedereenHal identificatie(String identificatie) {
    
    this.identificatie = identificatie;
    return this;
  }

   /**
   * Get identificatie
   * @return identificatie
  **/
  @ApiModelProperty(required = true, value = "")

  public String getIdentificatie() {
    return identificatie;
  }


  public void setIdentificatie(String identificatie) {
    this.identificatie = identificatie;
  }


  public JuridischeRegelVoorIedereenHal locatieIdentificaties(List<String> locatieIdentificaties) {
    
    this.locatieIdentificaties = locatieIdentificaties;
    return this;
  }

  public JuridischeRegelVoorIedereenHal addLocatieIdentificatiesItem(String locatieIdentificatiesItem) {
    this.locatieIdentificaties.add(locatieIdentificatiesItem);
    return this;
  }

   /**
   * Get locatieIdentificaties
   * @return locatieIdentificaties
  **/
  @ApiModelProperty(required = true, value = "")

  public List<String> getLocatieIdentificaties() {
    return locatieIdentificaties;
  }


  public void setLocatieIdentificaties(List<String> locatieIdentificaties) {
    this.locatieIdentificaties = locatieIdentificaties;
  }


  public JuridischeRegelVoorIedereenHal normeertActiviteiten(List<ActiviteitLocatieaanduiding> normeertActiviteiten) {
    
    this.normeertActiviteiten = normeertActiviteiten;
    return this;
  }

  public JuridischeRegelVoorIedereenHal addNormeertActiviteitenItem(ActiviteitLocatieaanduiding normeertActiviteitenItem) {
    if (this.normeertActiviteiten == null) {
      this.normeertActiviteiten = new ArrayList<>();
    }
    this.normeertActiviteiten.add(normeertActiviteitenItem);
    return this;
  }

   /**
   * Get normeertActiviteiten
   * @return normeertActiviteiten
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<ActiviteitLocatieaanduiding> getNormeertActiviteiten() {
    return normeertActiviteiten;
  }


  public void setNormeertActiviteiten(List<ActiviteitLocatieaanduiding> normeertActiviteiten) {
    this.normeertActiviteiten = normeertActiviteiten;
  }


  public JuridischeRegelVoorIedereenHal omschrijving(String omschrijving) {
    
    this.omschrijving = omschrijving;
    return this;
  }

   /**
   * Get omschrijving
   * @return omschrijving
  **/
  @ApiModelProperty(required = true, value = "")

  public String getOmschrijving() {
    return omschrijving;
  }


  public void setOmschrijving(String omschrijving) {
    this.omschrijving = omschrijving;
  }


  public JuridischeRegelVoorIedereenHal regeltekstIdentificatie(String regeltekstIdentificatie) {
    
    this.regeltekstIdentificatie = regeltekstIdentificatie;
    return this;
  }

   /**
   * Get regeltekstIdentificatie
   * @return regeltekstIdentificatie
  **/
  @ApiModelProperty(required = true, value = "")

  public String getRegeltekstIdentificatie() {
    return regeltekstIdentificatie;
  }


  public void setRegeltekstIdentificatie(String regeltekstIdentificatie) {
    this.regeltekstIdentificatie = regeltekstIdentificatie;
  }


  public JuridischeRegelVoorIedereenHal themas(List<Thema> themas) {
    
    this.themas = themas;
    return this;
  }

  public JuridischeRegelVoorIedereenHal addThemasItem(Thema themasItem) {
    if (this.themas == null) {
      this.themas = new ArrayList<>();
    }
    this.themas.add(themasItem);
    return this;
  }

   /**
   * Get themas
   * @return themas
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public List<Thema> getThemas() {
    return themas;
  }


  public void setThemas(List<Thema> themas) {
    this.themas = themas;
  }


  public JuridischeRegelVoorIedereenHal links(JuridischeRegelVoorIedereenLinks links) {
    
    this.links = links;
    return this;
  }

   /**
   * Get links
   * @return links
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public JuridischeRegelVoorIedereenLinks getLinks() {
    return links;
  }


  public void setLinks(JuridischeRegelVoorIedereenLinks links) {
    this.links = links;
  }


  public JuridischeRegelVoorIedereenHal embedded(JuridischeRegelVoorIedereenEmbedded embedded) {
    
    this.embedded = embedded;
    return this;
  }

   /**
   * Get embedded
   * @return embedded
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public JuridischeRegelVoorIedereenEmbedded getEmbedded() {
    return embedded;
  }


  public void setEmbedded(JuridischeRegelVoorIedereenEmbedded embedded) {
    this.embedded = embedded;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    JuridischeRegelVoorIedereenHal juridischeRegelVoorIedereenHal = (JuridischeRegelVoorIedereenHal) o;
    return Objects.equals(this.begindatum, juridischeRegelVoorIedereenHal.begindatum) &&
        Objects.equals(this.einddatum, juridischeRegelVoorIedereenHal.einddatum) &&
        Objects.equals(this.idealisatie, juridischeRegelVoorIedereenHal.idealisatie) &&
        Objects.equals(this.identificatie, juridischeRegelVoorIedereenHal.identificatie) &&
        Objects.equals(this.locatieIdentificaties, juridischeRegelVoorIedereenHal.locatieIdentificaties) &&
        Objects.equals(this.normeertActiviteiten, juridischeRegelVoorIedereenHal.normeertActiviteiten) &&
        Objects.equals(this.omschrijving, juridischeRegelVoorIedereenHal.omschrijving) &&
        Objects.equals(this.regeltekstIdentificatie, juridischeRegelVoorIedereenHal.regeltekstIdentificatie) &&
        Objects.equals(this.themas, juridischeRegelVoorIedereenHal.themas) &&
        Objects.equals(this.links, juridischeRegelVoorIedereenHal.links) &&
        Objects.equals(this.embedded, juridischeRegelVoorIedereenHal.embedded);
  }

  @Override
  public int hashCode() {
    return Objects.hash(begindatum, einddatum, idealisatie, identificatie, locatieIdentificaties, normeertActiviteiten, omschrijving, regeltekstIdentificatie, themas, links, embedded);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class JuridischeRegelVoorIedereenHal {\n");
    sb.append("    begindatum: ").append(toIndentedString(begindatum)).append("\n");
    sb.append("    einddatum: ").append(toIndentedString(einddatum)).append("\n");
    sb.append("    idealisatie: ").append(toIndentedString(idealisatie)).append("\n");
    sb.append("    identificatie: ").append(toIndentedString(identificatie)).append("\n");
    sb.append("    locatieIdentificaties: ").append(toIndentedString(locatieIdentificaties)).append("\n");
    sb.append("    normeertActiviteiten: ").append(toIndentedString(normeertActiviteiten)).append("\n");
    sb.append("    omschrijving: ").append(toIndentedString(omschrijving)).append("\n");
    sb.append("    regeltekstIdentificatie: ").append(toIndentedString(regeltekstIdentificatie)).append("\n");
    sb.append("    themas: ").append(toIndentedString(themas)).append("\n");
    sb.append("    links: ").append(toIndentedString(links)).append("\n");
    sb.append("    embedded: ").append(toIndentedString(embedded)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

