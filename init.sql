CREATE TABLE userinfo
(
    usin_id NUMBER,
    usin_name VARCHAR2(50) NOT NULL,
    CONSTRAINT pk_userinfo PRIMARY KEY(usin_id),
    CONSTRAINT uk_name UNIQUE(usin_name)
);

INSERT INTO userinfo SELECT username FROM dba_users;

CREATE TABLE scriptinfo
(
    scin_id NUMBER,
    scin_title VARCHAR2(128) NOT NULL,
    scin_hashcode NUMBER,
    CONSTRAINT pk_scriptinfo PRIMARY KEY (scin_id),
    CONSTRAINT uk_hashcode UNIQUE(scin_hashcode)
);

CREATE TABLE executelog
(
    usin_id NUMBER NOT NULL,
    scin_id NUMBER NOT NULL,
    exlo_result VARCHAR2(10) NOT NULL,
    CONSTRAINT pk_executelog PRIMARY KEY(usin_id,scin_id),
    CONSTRAINT fk_usin_id FOREIGN KEY(usin_id) REFERENCES userinfo(usin_id) ON DELETE CASCADE,
    CONSTRAINT fk_scin_id FOREIGN KEY(scin_id) REFERENCES scriptinfo(scin_id) ON DELETE CASCADE,
    CONSTRAINT ck_result CHECK(exlo_result IN ('success','fail'))
);

exit