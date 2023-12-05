import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-proekt-участник', 'Unit | Serializer | i-i-s-proekt-участник', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-proekt-участник',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-proekt-роли',

    'model:i-i-s-proekt-календарь',
    'model:i-i-s-proekt-проект-и-с',
    'model:i-i-s-proekt-участник',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
