insert into [User](Username, Password, Created, Modified, Active)
values ('Admin', 'a', getdate(), null, 1);

insert into CharClass(Name, Code, HitDice) values ('Druid', 'DRUID', 8);

insert into Race(Name, Speed, Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma, SuperRace_ID)
values ('Halfling', 25, 0, 2, 0, 0, 0, 0, null);

insert into Race(Name, Speed, Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma, SuperRace_ID)
values ('Lightfoot Halfling', 25, 0, 2, 0, 0, 0, 1, (select ID from Race where Name = 'Halfling'));

insert into Spell(Name, CastingTime, Range, Components, Duration, Materials, Description, Family, Level, Custom, Created, Modified, Active, Class_ID, ModificationUser_ID, Owner_ID)
values ('Guidance', '1 action', 'Touch', 'V, S', 'Concentration, up to 1 minute', null,
        'You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one ability check of its choice. It can roll the die before or after making the ability check. The spell then ends.', 'Divination',
        0, 0, getdate(), null, 1, (select ID from CharClass where Name = 'Druid'), null, null);