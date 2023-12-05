import Mixin from '@ember/object/mixin';
import $ from 'jquery';

export let Serializer = Mixin.create({
  getAttrs: function () {
    let parentAttrs = this._super();
    let attrs = {
      планирование: { serialize: 'odata-id', deserialize: 'records' },
      проектИС: { serialize: 'odata-id', deserialize: 'records' },
      роли: { serialize: 'odata-id', deserialize: 'records' },
      участник: { serialize: 'odata-id', deserialize: 'records' }
    };

    return $.extend(true, {}, parentAttrs, attrs);
  },
  init: function () {
    this.set('attrs', this.getAttrs());
    this._super(...arguments);
  }
});
