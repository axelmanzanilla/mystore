--**************************************************************
--** TABLE CREATION SECTION
--**************************************************************

drop table if exists shoppingcarts;
drop table if exists user_logged;
drop table if exists products;
drop table if exists users;

create table products
(
    id          TEXT primary key,
    description TEXT not null unique,
    category    TEXT not null,
    price       REAL not null,
    image       TEXT not null,
    active      INTEGER not null
);

create table users
(
    id        INTEGER primary key,
    firstname TEXT not null,
    lastname  TEXT not null,
    username  TEXT not null unique,
    password  TEXT not null,
    image     TEXT not null
);

create table shoppingcarts
(
    user_id    INTEGER not null references users(id),
    product_id TEXT not null references products(id),
    quantity   INTEGER not null
);

create table user_logged
(
    user_id INTEGER not null references users(id)
);

--**************************************************************
--** TEST DATA
--**************************************************************

INSERT INTO products (id, description, category, price, image, active) VALUES ('34050', 'Telefono inalambrico Panasonic', 'Telefonos', 798.99, '34050.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('34950', 'Blu-Ray 3D Smart LG', 'Reproductores', 1699, '34950.jpg', 0);
INSERT INTO products (id, description, category, price, image, active) VALUES ('36921', 'Reproductor Blu-Ray Samsung', 'Reproductores', 798.99, '36921.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('37590', 'Duracell Quantum', 'Accesorios', 239, '37590.jpg', 0);
INSERT INTO products (id, description, category, price, image, active) VALUES ('39493', 'Camara Powershot', 'Camaras', 3599, '39493.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('48928', 'Party Machine Dual Phillips', 'Estereos', 3998.99, '48928.jpg', 0);
INSERT INTO products (id, description, category, price, image, active) VALUES ('49402', 'Cine en casa 2.1C Bose', 'Estereos', 8999, '49402.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('59820', 'Cable auxiliar 3.5mm Belkin', 'Accesorios', 108.99, '59820.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('73254', 'Pantalla 42 plg LED LG', 'Televisores', 9999, '73254.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('74320', 'Radio dos vias Motorola', 'Accesorios', 899, '74320.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('84329', 'Mini componente Xboom LG', 'Estereos', 11999, '84329.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('84509', 'Camara WB2200 Samsung', 'Camaras', 5290.99, '84509.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('84924', 'Pantalla 50 plg Smart UHD Samsung', 'Televisores', 15998.99, '84924.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('93082', 'Camara L330 Nikon', 'Camaras', 2998.99, '93082.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('95402', 'Pantalla 70 plg 3D Sharp', 'Televisores', 39999, '95402.jpg', 1);
INSERT INTO products (id, description, category, price, image, active) VALUES ('95834', 'Pantalla 55 LED LG', 'Televisores', 21999, '95834.jpg', 0);
INSERT INTO products (id, description, category, price, image, active) VALUES ('98603', 'Camara ILCE 3500 Sony', 'Camaras', 5998.99, '98603.jpg', 0);

INSERT INTO users (id, firstname, lastname, username, password, image) VALUES (0, 'Admin', '', 'admin', 'admin', 'default.png');
INSERT INTO users (id, firstname, lastname, username, password, image) VALUES (1, 'Alan', 'Puerto', 'APuerto', '1238', 'default.png');
INSERT INTO users (id, firstname, lastname, username, password, image) VALUES (2, 'Pamela', 'Reyes', 'pamelare', '1122', 'default.png');
INSERT INTO users (id, firstname, lastname, username, password, image) VALUES (3, 'Jose', 'Maldonado', 'Maldonado', '1234', 'default.png');
INSERT INTO users (id, firstname, lastname, username, password, image) VALUES (4, 'Evelyn', 'Chable', 'evelynchable', '9999', 'default.png');
INSERT INTO users (id, firstname, lastname, username, password, image) VALUES (5, 'Oswaldo', 'Vadillo', 'VadO', '1172', 'default.png');