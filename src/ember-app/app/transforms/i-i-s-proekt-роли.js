import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import РолиEnum from '../enums/i-i-s-proekt-роли';

export default FlexberryEnum.extend({
  enum: РолиEnum,
  sourceType: 'IIS.Proekt.Роли'
});
