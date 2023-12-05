import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  ValidationRules,
  Model as ПроектИСMixin
} from '../mixins/regenerated/models/i-i-s-proekt-проект-и-с';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ПроектИСMixin, Validations, {
});

export default Model;
