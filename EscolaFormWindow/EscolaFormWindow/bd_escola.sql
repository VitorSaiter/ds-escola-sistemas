create database bd_escola;
use bd_escola;

CREATE TABLE Escola(
id_esc int not null auto_increment,
nome_fantasia_esc varchar(200) not null,
razao_social_esc varchar(200) not null,
cnpj_esc varchar(200) not null,
insc_estadual_esc varchar(200) not null,
tipo_esc varchar(200) not null, 
data_criacao_esc date not null, 
responsavel_esc varchar(200) not null,
responsavel_telefone_esc varchar(200) not null,
email_esc varchar(200) not null, 
telefone_esc varchar(200) not null,
rua_esc varchar(200) not null,
numero_esc varchar(200) not null, 
bairro_esc varchar(200) not null,
complemento_esc varchar(200)not null,
cep_esc varchar(200) not null,
cidade_esc varchar(200) not null,
estado_esc varchar(200) not null,
primary key(id_esc)
);

insert into Escola values(1, 'Escola Vitor Saiter', 'Escola Vitor Saiter', '86.441.221/0001-10', '251.154.647.034', 'Militar', 
'2000-01-18', 'Carlos Alexandre', '69 992566814', 'vitorsaiter@gmail.com', '69 998451237', 'Rua Olinda', '40', 'Incra', 'Próximo ao detran', '76920-000', 'Ouro Preto do Oeste', 'Rondônia');