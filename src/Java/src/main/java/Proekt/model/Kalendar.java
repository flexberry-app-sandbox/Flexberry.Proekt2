package Proekt.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Proekt.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;

/**
 * Entity implementation class for Entity: Календарь
 */
@Entity(name = "IISProektКалендарь")
@Table(schema = "public", name = "Календарь")
public class Kalendar {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "Начало")
    private String начало;

    @Column(name = "Трудозатраты")
    private Integer трудозатраты;

    @Column(name = "Конец")
    private String конец;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Planirovanie")
    @Convert("Planirovanie")
    @Column(name = "Планирование", length = 16, unique = true, nullable = false)
    private UUID _planirovanieid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Planirovanie", insertable = false, updatable = false)
    private Planirovanie planirovanie;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "ProektIS")
    @Convert("ProektIS")
    @Column(name = "ПроектИС", length = 16, unique = true, nullable = false)
    private UUID _proektisid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "ProektIS", insertable = false, updatable = false)
    private ProektIS proektis;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Uchastnik")
    @Convert("Uchastnik")
    @Column(name = "Участник", length = 16, unique = true, nullable = false)
    private UUID _uchastnikid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Uchastnik", insertable = false, updatable = false)
    private Uchastnik uchastnik;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "Roli")
    @Convert("Roli")
    @Column(name = "Роли", length = 16, unique = true, nullable = false)
    private UUID _roliid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "Roli", insertable = false, updatable = false)
    private Roli roli;


    public Kalendar() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public String getНачало() {
      return начало;
    }

    public void setНачало(String начало) {
      this.начало = начало;
    }

    public Integer getТрудозатраты() {
      return трудозатраты;
    }

    public void setТрудозатраты(Integer трудозатраты) {
      this.трудозатраты = трудозатраты;
    }

    public String getКонец() {
      return конец;
    }

    public void setКонец(String конец) {
      this.конец = конец;
    }


}