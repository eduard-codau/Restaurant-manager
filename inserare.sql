-- login
insert into login values('admin','admin', TO_DATE('05.10.2021','DD.MM.YYYY'),1);
insert into login values('chiti.matei','chiti.matei', TO_DATE('05.10.2021','DD.MM.YYYY'),0);
insert into login values('eduard.codau','eduard.codau', TO_DATE('04.10.2021','DD.MM.YYYY'),0);
insert into login values('alexandru.secman','alexandru.secman', TO_DATE('06.10.2021','DD.MM.YYYY'),0);
insert into login values('cristina.nichiforeac','cristina.nichiforeac', TO_DATE('07.10.2021','DD.MM.YYYY'),0);

--ospatar
insert into ospatar values(1, 'Chiti Matei', 0756784125, 'chiti.matei');
insert into ospatar values(2, 'Codau Eduard', 0735268475, 'eduard.codau');
insert into ospatar values(3, 'Secman Alexandru', 0788652374, 'alexandru.secman');
insert into ospatar values(4, 'Nichiforeac Cristina', 0756812354, 'cristina.nichiforeac');

--masa
insert into masa values(1, 6, 'libera');
insert into masa values(2, 6, 'libera');
insert into masa values(3, 6, 'libera');
insert into masa values(4, 6, 'libera');
insert into masa values(5, 4, 'libera');
insert into masa values(6, 4, 'libera');
insert into masa values(7, 4, 'libera');
insert into masa values(8, 4, 'libera');

--meniu
insert into meniu values(1,'ciorbe');
insert into meniu values(2,'garnituri');
insert into meniu values(3,'salate');
insert into meniu values(4,'paste');
insert into meniu values(5,'pizza');
insert into meniu values(6,'bauturi alcoolice');
insert into meniu values(7,'sucuri');

--produs

insert into produs values ('Ciorba radauteana', 14.99, 300, 'gram', 1);
insert into produs values ('Ciorba de vacuta', 14.99, 300, 'gram', 1);
insert into produs values ('Ciorba de legume', 11.99, 300, 'gram', 1);

insert into produs values ('Salata caesar', 27.99, 400, 'gram', 3);
insert into produs values ('Crispy salad', 25.99, 400, 'gram', 3);
insert into produs values ('Salata cu avocado si rosii cherry', 30.99, 420, 'gram', 3);

insert into produs values ('Quattro stagioni', 27.99, 450, 'gram', 5);
insert into produs values ('Diavolo', 26.99, 450, 'gram', 5);
insert into produs values ('Carnivore', 32.99, 500, 'gram', 5);

insert into produs values ('Bere Peroni', 6.99, 0.33, 'litru', 6);
insert into produs values ('Bere Ursus Grizzly', 4.99, 0.33, 'litru', 6);

insert into produs values ('Paste Carbonara', 31.99, 330, 'gram',4);
insert into produs values ('Paste penne polo', 28.99, 350, 'gram', 4);

insert into produs values ('Cartofi natur', 6.99, 200, 'gram', 2);
insert into produs values ('Cartofi pai cu parmezan', 7.99, 200, 'gram', 2);

insert into produs values ('Sprite', 7, 0.5, 'litru',7);
insert into produs values ('Schweppes', 7, 0.5, 'litru', 7);
