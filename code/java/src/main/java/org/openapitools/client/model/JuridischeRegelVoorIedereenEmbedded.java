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
import java.util.ArrayList;
import java.util.List;
import org.openapitools.client.model.LocatieHal;
import org.openapitools.client.model.RegeltekstHal;

/**
 * JuridischeRegelVoorIedereenEmbedded
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2021-02-10T09:19:26.366Z[Etc/UTC]")
public class JuridischeRegelVoorIedereenEmbedded {
  public static final String SERIALIZED_NAME_GEDEFINIEERDE_LOCATIES = "gedefinieerdeLocaties";
  @SerializedName(SERIALIZED_NAME_GEDEFINIEERDE_LOCATIES)
  private List<LocatieHal> gedefinieerdeLocaties = null;

  public static final String SERIALIZED_NAME_OMVATTENDE_REGELTEKST = "omvattendeRegeltekst";
  @SerializedName(SERIALIZED_NAME_OMVATTENDE_REGELTEKST)
  private RegeltekstHal omvattendeRegeltekst = null;


  public JuridischeRegelVoorIedereenEmbedded gedefinieerdeLocaties(List<LocatieHal> gedefinieerdeLocaties) {
    
    this.gedefinieerdeLocaties = gedefinieerdeLocaties;
    return this;
  }

  public JuridischeRegelVoorIedereenEmbedded addGedefinieerdeLocatiesItem(LocatieHal gedefinieerdeLocatiesItem) {
    if (this.gedefinieerdeLocaties == null) {
      this.gedefinieerdeLocaties = new ArrayList<>();
    }
    this.gedefinieerdeLocaties.add(gedefinieerdeLocatiesItem);
    return this;
  }

   /**
   * &lt;body&gt;&lt;p&gt;De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Een inhoudelijke toelichting op de toepassing van het informatie-element.&lt;/p&gt;&lt;/body&gt;
   * @return gedefinieerdeLocaties
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "<body><p>De locatieaanduiding begrenst de juridische werking van de regel in juridische zin, te weten dat de regel alleen binnen dit werkingsgebied werkingskracht heeft.</p></body><body><p>Een inhoudelijke toelichting op de toepassing van het informatie-element.</p></body>")

  public List<LocatieHal> getGedefinieerdeLocaties() {
    return gedefinieerdeLocaties;
  }


  public void setGedefinieerdeLocaties(List<LocatieHal> gedefinieerdeLocaties) {
    this.gedefinieerdeLocaties = gedefinieerdeLocaties;
  }


  public JuridischeRegelVoorIedereenEmbedded omvattendeRegeltekst(RegeltekstHal omvattendeRegeltekst) {
    
    this.omvattendeRegeltekst = omvattendeRegeltekst;
    return this;
  }

   /**
   * Get omvattendeRegeltekst
   * @return omvattendeRegeltekst
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public RegeltekstHal getOmvattendeRegeltekst() {
    return omvattendeRegeltekst;
  }


  public void setOmvattendeRegeltekst(RegeltekstHal omvattendeRegeltekst) {
    this.omvattendeRegeltekst = omvattendeRegeltekst;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    JuridischeRegelVoorIedereenEmbedded juridischeRegelVoorIedereenEmbedded = (JuridischeRegelVoorIedereenEmbedded) o;
    return Objects.equals(this.gedefinieerdeLocaties, juridischeRegelVoorIedereenEmbedded.gedefinieerdeLocaties) &&
        Objects.equals(this.omvattendeRegeltekst, juridischeRegelVoorIedereenEmbedded.omvattendeRegeltekst);
  }

  @Override
  public int hashCode() {
    return Objects.hash(gedefinieerdeLocaties, omvattendeRegeltekst);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class JuridischeRegelVoorIedereenEmbedded {\n");
    sb.append("    gedefinieerdeLocaties: ").append(toIndentedString(gedefinieerdeLocaties)).append("\n");
    sb.append("    omvattendeRegeltekst: ").append(toIndentedString(omvattendeRegeltekst)).append("\n");
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

