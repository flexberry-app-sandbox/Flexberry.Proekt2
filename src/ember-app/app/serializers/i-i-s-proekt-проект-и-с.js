import { Serializer as ПроектИСSerializer } from
  '../mixins/regenerated/serializers/i-i-s-proekt-проект-и-с';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ПроектИСSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
