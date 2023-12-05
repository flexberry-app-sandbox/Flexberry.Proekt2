import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';

export let Model = Mixin.create({
  бюджет: DS.attr('number'),
  наименование: DS.attr('string'),
  срок: DS.attr('string')
});

export let ValidationRules = {
  бюджет: {
    descriptionKey: 'models.i-i-s-proekt-проект-и-с.validations.бюджет.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  наименование: {
    descriptionKey: 'models.i-i-s-proekt-проект-и-с.validations.наименование.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  срок: {
    descriptionKey: 'models.i-i-s-proekt-проект-и-с.validations.срок.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};
