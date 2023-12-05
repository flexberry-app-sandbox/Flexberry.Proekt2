import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-proekt-проект-и-с', 'Unit | Model | i-i-s-proekt-проект-и-с', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-proekt-календарь',
    'model:i-i-s-proekt-проект-и-с',
    'model:i-i-s-proekt-участник',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
