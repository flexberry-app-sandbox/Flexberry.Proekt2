import {
  defineNamespace,
  Model as КалендарьMixin
} from '../mixins/regenerated/models/i-i-s-proekt-календарь';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(КалендарьMixin, {
});

defineNamespace(Model);

export default Model;
