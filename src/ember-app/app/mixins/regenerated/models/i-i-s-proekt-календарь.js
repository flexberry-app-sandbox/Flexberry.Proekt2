import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';

export let Model = Mixin.create({
  конец: DS.attr('string'),
  начало: DS.attr('string'),
  трудозатраты: DS.attr('number'),
  планирование: DS.belongsTo('i-i-s-proekt-планирование', { inverse: null, async: false }),
  проектИС: DS.belongsTo('i-i-s-proekt-проект-и-с', { inverse: null, async: false }),
  роли: DS.belongsTo('i-i-s-proekt-роли', { inverse: null, async: false }),
  участник: DS.belongsTo('i-i-s-proekt-участник', { inverse: null, async: false })
});

export let ValidationRules = {
  конец: {
    descriptionKey: 'models.i-i-s-proekt-календарь.validations.конец.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  начало: {
    descriptionKey: 'models.i-i-s-proekt-календарь.validations.начало.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  трудозатраты: {
    descriptionKey: 'models.i-i-s-proekt-календарь.validations.трудозатраты.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  планирование: {
    descriptionKey: 'models.i-i-s-proekt-календарь.validations.планирование.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  проектИС: {
    descriptionKey: 'models.i-i-s-proekt-календарь.validations.проектИС.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  роли: {
    descriptionKey: 'models.i-i-s-proekt-календарь.validations.роли.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  участник: {
    descriptionKey: 'models.i-i-s-proekt-календарь.validations.участник.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};
