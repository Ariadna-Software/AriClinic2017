-- add column for field smsClave
ALTER TABLE `parameter` ADD COLUMN `sms_clave` VARCHAR(255) NULL
;

-- add column for field smsEmail
ALTER TABLE `parameter` ADD COLUMN `sms_email` VARCHAR(255) NULL
;

-- add column for field smsEmail
ALTER TABLE `parameter` ADD COLUMN `sms_remitente` VARCHAR(255) NULL
;
-- add column for field sms (in appointment)
ALTER TABLE `ariclinic_miestetic`.`appointment` ADD COLUMN `sms` BIT DEFAULT 0 NULL
;
