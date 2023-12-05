import {
  defineNamespace,
  Model as ПроектИСMixin
} from '../mixins/regenerated/models/i-i-s-proekt-проект-и-с';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ПроектИСMixin, {
});

defineNamespace(Model);

export default Model;
