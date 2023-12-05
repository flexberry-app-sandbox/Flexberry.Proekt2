package Proekt.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Proekt.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;


/**
 * Entity implementation class for Entity: ПроектИС
 */
@Entity(name = "IISProektПроектИС")
@Table(schema = "public", name = "ПроектИС")
public class ProektIS {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "Наименование")
    private String наименование;

    @Column(name = "Бюджет")
    private Integer бюджет;

    @Column(name = "Срок")
    private String срок;


    public ProektIS() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public String getНаименование() {
      return наименование;
    }

    public void setНаименование(String наименование) {
      this.наименование = наименование;
    }

    public Integer getБюджет() {
      return бюджет;
    }

    public void setБюджет(Integer бюджет) {
      this.бюджет = бюджет;
    }

    public String getСрок() {
      return срок;
    }

    public void setСрок(String срок) {
      this.срок = срок;
    }


}