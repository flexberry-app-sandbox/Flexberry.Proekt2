import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';

export let Model = Mixin.create({
  роль: DS.attr('i-i-s-proekt-роли'),
  фИО: DS.attr('string')
});

export let ValidationRules = {
  роль: {
    descriptionKey: 'models.i-i-s-proekt-участник.validations.роль.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  фИО: {
    descriptionKey: 'models.i-i-s-proekt-участник.validations.фИО.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};
