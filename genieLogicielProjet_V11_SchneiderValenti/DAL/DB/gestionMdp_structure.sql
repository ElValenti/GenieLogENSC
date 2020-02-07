  
create database if not exists gestionMdp character set utf8 collate utf8_unicode_ci;
use gestionMdp;

grant all privileges on gestionMdp.* to 'gestionMdp_user'@'localhost' identified by 'secret';

drop table if exists compte;
drop table if exists utilisateur;
drop table if exists wifi;

create table utilisateur (
    util_id integer not null primary key auto_increment,
    util_nom varchar(100) not null,
    util_mdpPrincipal varchar(50) not null
);

create table wifi (
	wifi_id integer not null primary key auto_increment,
    wifi_titre varchar(100) not null,
	wifi_ssid varchar(100) not null,
    wifi_mdp varchar(100) not null,
	util_id integer not null,
    foreign key (util_id) references utilisateur(util_id)
);

create table compte (
	compte_id integer not null primary key auto_increment,
    compte_titre varchar(100) not null,
	compte_nomUtil varchar(100) not null,
    compte_mdp varchar(50) not null,
	util_id integer not null,
    foreign key (util_id) references utilisateur(util_id)
);
