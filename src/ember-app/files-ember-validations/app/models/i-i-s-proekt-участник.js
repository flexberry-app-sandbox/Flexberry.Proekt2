import {
  defineNamespace,
  Model as УчастникMixin
} from '../mixins/regenerated/models/i-i-s-proekt-участник';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(УчастникMixin, {
});

defineNamespace(Model);

export default Model;
