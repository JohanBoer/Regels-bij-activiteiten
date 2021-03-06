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
import io.swagger.annotations.ApiModel;
import com.google.gson.annotations.SerializedName;

import java.io.IOException;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;

/**
 * &lt;body&gt;&lt;p&gt;Is dit een definitie?&lt;/p&gt;&lt;/body&gt;&lt;body&gt;&lt;p&gt;Is dit een definitie?&lt;/p&gt;&lt;/body&gt;
 */
@JsonAdapter(LocatieType.Adapter.class)
public enum LocatieType {
  
  PUNT("punt"),
  
  AMBTSGEBIED("ambtsgebied"),
  
  PUNTENGROEP("puntengroep"),
  
  GEBIED("gebied"),
  
  GEBIEDENGROEP("gebiedengroep"),
  
  LIJN("lijn"),
  
  LIJNENGROEP("lijnengroep");

  private String value;

  LocatieType(String value) {
    this.value = value;
  }

  public String getValue() {
    return value;
  }

  @Override
  public String toString() {
    return String.valueOf(value);
  }

  public static LocatieType fromValue(String value) {
    for (LocatieType b : LocatieType.values()) {
      if (b.value.equals(value)) {
        return b;
      }
    }
    throw new IllegalArgumentException("Unexpected value '" + value + "'");
  }

  public static class Adapter extends TypeAdapter<LocatieType> {
    @Override
    public void write(final JsonWriter jsonWriter, final LocatieType enumeration) throws IOException {
      jsonWriter.value(enumeration.getValue());
    }

    @Override
    public LocatieType read(final JsonReader jsonReader) throws IOException {
      String value = jsonReader.nextString();
      return LocatieType.fromValue(value);
    }
  }
}

