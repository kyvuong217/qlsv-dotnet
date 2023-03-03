create database QLSinhVien;
drop database QLSinhVien;

create table account(
	username varchar(255) primary key,
	passwd varchar(255), 
	role varchar(255)
);

create table class(
	class_id varchar(255) primary key,
	class_name varchar(255) 
);

create table student(
	student_ID varchar(255) primary key,
	student_name varchar(255),
	student_dob date,
	student_class varchar(255),
	FOREIGN KEY(student_ID) REFERENCES account(username),
	FOREIGN KEY(student_class) REFERENCES class(class_id)
);

create table teacher(
	teacher_ID varchar(255) primary key,
	teacher_name varchar(255),
	teacher_dob date,
	FOREIGN KEY(teacher_ID) REFERENCES account(username)
);



create table subj(
	subj_ID varchar(255) primary key,
	subj_name varchar(255)
);

create table transcript(
	transcript_id INT IDENTITY(1,1) PRIMARY KEY,
	transcript_subj varchar(255),
	transcript_student varchar(255),
	transcript_teacher varchar(255),
	transcript_point float
	FOREIGN KEY(transcript_subj) REFERENCES subj(subj_ID),
	FOREIGN KEY(transcript_student) REFERENCES student(student_ID),
	FOREIGN KEY(transcript_teacher) REFERENCES teacher(teacher_ID)
);




insert into account values ('B1809811','123456', 'teacher');
insert into account values ('B1809812','123456', 'teacher');
insert into account values ('B1809813','123456', 'teacher');
insert into account values ('B1809814','123456', 'teacher');
insert into account values ('B1809815','123456', 'teacher');
insert into account values ('B1809816','123456', 'teacher');
insert into account values ('B1809817','123456', 'teacher');
insert into account values ('B1809818','123456', 'teacher');
insert into account values ('B1809819','123456', 'teacher');
insert into account values ('B1809820','123456', 'teacher');

insert into account values ('B1809711','123456', 'student');
insert into account values ('B1809712','123456', 'student');
insert into account values ('B1809713','123456', 'student');
insert into account values ('B1809714','123456', 'student');
insert into account values ('B1809715','123456', 'student');
insert into account values ('B1809716','123456', 'student');
insert into account values ('B1809717','123456', 'student');
insert into account values ('B1809718','123456', 'student');
insert into account values ('B1809719','123456', 'student');
insert into account values ('B1809720','123456', 'student');

insert into account values ('B1809721','123456', 'student');
insert into account values ('B1809722','123456', 'student');
insert into account values ('B1809723','123456', 'student');
insert into account values ('B1809724','123456', 'student');
insert into account values ('B1809725','123456', 'student');
insert into account values ('B1809726','123456', 'student');
insert into account values ('B1809727','123456', 'student');
insert into account values ('B1809728','123456', 'student');
insert into account values ('B1809729','123456', 'student');
insert into account values ('B1809730','123456', 'student');

insert into account values ('B1809731','123456', 'student');
insert into account values ('B1809732','123456', 'student');
insert into account values ('B1809733','123456', 'student');
insert into account values ('B1809734','123456', 'student');
insert into account values ('B1809735','123456', 'student');
insert into account values ('B1809736','123456', 'student');
insert into account values ('B1809737','123456', 'student');
insert into account values ('B1809738','123456', 'student');
insert into account values ('B1809739','123456', 'student');
insert into account values ('B1809740','123456', 'student');

insert into account values ('B1809741','123456', 'student');
insert into account values ('B1809742','123456', 'student');
insert into account values ('B1809743','123456', 'student');
insert into account values ('B1809744','123456', 'student');
insert into account values ('B1809745','123456', 'student');
insert into account values ('B1809746','123456', 'student');
insert into account values ('B1809747','123456', 'student');
insert into account values ('B1809748','123456', 'student');
insert into account values ('B1809749','123456', 'student');
insert into account values ('B1809750','123456', 'student');

insert into account values ('B1809751','123456', 'student');
insert into account values ('B1809752','123456', 'student');
insert into account values ('B1809753','123456', 'student');
insert into account values ('B1809754','123456', 'student');
insert into account values ('B1809755','123456', 'student');
insert into account values ('B1809756','123456', 'student');
insert into account values ('B1809757','123456', 'student');
insert into account values ('B1809758','123456', 'student');
insert into account values ('B1809759','123456', 'student');
insert into account values ('B1809760','123456', 'student');

insert into account values ('B1809761','123456', 'student');
insert into account values ('B1809762','123456', 'student');
insert into account values ('B1809763','123456', 'student');
insert into account values ('B1809764','123456', 'student');
insert into account values ('B1809765','123456', 'student');
insert into account values ('B1809766','123456', 'student');
insert into account values ('B1809767','123456', 'student');
insert into account values ('B1809768','123456', 'student');
insert into account values ('B1809769','123456', 'student');
insert into account values ('B1809770','123456', 'student');

insert into account values ('B1809771','123456', 'student');
insert into account values ('B1809772','123456', 'student');
insert into account values ('B1809773','123456', 'student');
insert into account values ('B1809774','123456', 'student');
insert into account values ('B1809775','123456', 'student');
insert into account values ('B1809776','123456', 'student');
insert into account values ('B1809777','123456', 'student');
insert into account values ('B1809778','123456', 'student');
insert into account values ('B1809779','123456', 'student');
insert into account values ('B1809780','123456', 'student');

insert into account values ('B1809781','123456', 'student');
insert into account values ('B1809782','123456', 'student');
insert into account values ('B1809783','123456', 'student');
insert into account values ('B1809784','123456', 'student');
insert into account values ('B1809785','123456', 'student');
insert into account values ('B1809786','123456', 'student');
insert into account values ('B1809787','123456', 'student');
insert into account values ('B1809788','123456', 'student');
insert into account values ('B1809789','123456', 'student');
insert into account values ('B1809790','123456', 'student');

insert into class values ('DI18V7F1', 'CNTT-CLC-01');
insert into class values ('DI18V7F2', 'CNTT-CLC-02');
insert into class values ('DI18V7A1', 'CNTT-01');
insert into class values ('DI18V7A2', 'CNTT-02');
insert into class values ('DI18V7A3', 'CNTT-03');
insert into class values ('DI18V7A4', 'CNTT-04');


insert into student values ('B1809711', 'Nguyen Van A', '2000-01-01', 'DI18V7F1');
insert into student values ('B1809712', 'Quach Van B', '2000-02-02', 'DI18V7F1');
insert into student values ('B1809713', 'Nguyen Minh C', '2000-09-03', 'DI18V7F1');
insert into student values ('B1809714', 'Tran Ngoc D', '2000-08-04', 'DI18V7F1');
insert into student values ('B1809715', 'Le Nguyen E', '2000-03-05', 'DI18V7F1');
insert into student values ('B1809716', 'Ngo Quoc F', '2000-07-06', 'DI18V7F1');
insert into student values ('B1809717', 'Do Bo G', '2000-05-07', 'DI18V7F1');
insert into student values ('B1809718', 'Le Tran H', '2000-12-08', 'DI18V7F1');
insert into student values ('B1809719', 'Phan Hoang I', '2000-07-09', 'DI18V7F1');
insert into student values ('B1809720', 'Phan Minh J', '2000-10-10', 'DI18V7F1');


insert into student values ('B1809721', 'Nguyen Van A', '2000-01-01', 'DI18V7F2');
insert into student values ('B1809722', 'Quach Van B', '2000-02-02', 'DI18V7F2');
insert into student values ('B1809723', 'Nguyen Minh C', '2000-09-03', 'DI18V7F2');
insert into student values ('B1809724', 'Tran Ngoc D', '2000-08-04', 'DI18V7F2');
insert into student values ('B1809725', 'Le Nguyen E', '2000-03-05', 'DI18V7F2');
insert into student values ('B1809726', 'Ngo Quoc F', '2000-07-06', 'DI18V7F2');
insert into student values ('B1809727', 'Do Bo G', '2000-05-07', 'DI18V7F2');
insert into student values ('B1809728', 'Le Tran H', '2000-12-08', 'DI18V7F2');
insert into student values ('B1809729', 'Phan Hoang I', '2000-07-09', 'DI18V7F2');
insert into student values ('B1809730', 'Phan Minh J', '2000-10-10', 'DI18V7F2');


insert into student values ('B1809731', 'Nguyen Van A', '2000-01-01', 'DI18V7A1');
insert into student values ('B1809732', 'Quach Van B', '2000-02-02', 'DI18V7A1');
insert into student values ('B1809733', 'Nguyen Minh C', '2000-09-03', 'DI18V7A1');
insert into student values ('B1809734', 'Tran Ngoc D', '2000-08-04', 'DI18V7A1');
insert into student values ('B1809735', 'Le Nguyen E', '2000-03-05', 'DI18V7A1');
insert into student values ('B1809736', 'Ngo Quoc F', '2000-07-06', 'DI18V7A1');
insert into student values ('B1809737', 'Do Bo G', '2000-05-07', 'DI18V7A1');
insert into student values ('B1809738', 'Le Tran H', '2000-12-08', 'DI18V7A1');
insert into student values ('B1809739', 'Phan Hoang I', '2000-07-09', 'DI18V7A1');
insert into student values ('B1809740', 'Phan Minh J', '2000-10-10', 'DI18V7A1');



insert into student values ('B1809741', 'Nguyen Van A', '2000-01-01', 'DI18V7A2');
insert into student values ('B1809742', 'Quach Van B', '2000-02-02', 'DI18V7A2');
insert into student values ('B1809743', 'Nguyen Minh C', '2000-09-03', 'DI18V7A2');
insert into student values ('B1809744', 'Tran Ngoc D', '2000-08-04', 'DI18V7A2');
insert into student values ('B1809745', 'Le Nguyen E', '2000-03-05', 'DI18V7A2');
insert into student values ('B1809746', 'Ngo Quoc F', '2000-07-06', 'DI18V7A2');
insert into student values ('B1809747', 'Do Bo G', '2000-05-07', 'DI18V7A2');
insert into student values ('B1809748', 'Le Tran H', '2000-12-08', 'DI18V7A2');
insert into student values ('B1809749', 'Phan Hoang I', '2000-07-09', 'DI18V7A2');
insert into student values ('B1809750', 'Phan Minh J', '2000-10-10', 'DI18V7A2');

insert into student values ('B1809751', 'Nguyen Van A', '2000-01-01', 'DI18V7A3');
insert into student values ('B1809752', 'Quach Van B', '2000-02-02', 'DI18V7A3');
insert into student values ('B1809753', 'Nguyen Minh C', '2000-09-03', 'DI18V7A3');
insert into student values ('B1809754', 'Tran Ngoc D', '2000-08-04', 'DI18V7A3');
insert into student values ('B1809755', 'Le Nguyen E', '2000-03-05', 'DI18V7A3');
insert into student values ('B1809756', 'Ngo Quoc F', '2000-07-06', 'DI18V7A3');
insert into student values ('B1809757', 'Do Bo G', '2000-05-07', 'DI18V7A3');
insert into student values ('B1809758', 'Le Tran H', '2000-12-08', 'DI18V7A3');
insert into student values ('B1809759', 'Phan Hoang I', '2000-07-09', 'DI18V7A3');
insert into student values ('B1809760', 'Phan Minh J', '2000-10-10', 'DI18V7A3');

insert into student values ('B1809761', 'Nguyen Van A', '2000-01-01', 'DI18V7A4');
insert into student values ('B1809762', 'Quach Van B', '2000-02-02', 'DI18V7A4');
insert into student values ('B1809763', 'Nguyen Minh C', '2000-09-03', 'DI18V7A4');
insert into student values ('B1809764', 'Tran Ngoc D', '2000-08-04', 'DI18V7A4');
insert into student values ('B1809765', 'Le Nguyen E', '2000-03-05', 'DI18V7A4');
insert into student values ('B1809766', 'Ngo Quoc F', '2000-07-06', 'DI18V7A4');
insert into student values ('B1809767', 'Do Bo G', '2000-05-07', 'DI18V7A4');
insert into student values ('B1809768', 'Le Tran H', '2000-12-08', 'DI18V7A4');
insert into student values ('B1809769', 'Phan Hoang I', '2000-07-09', 'DI18V7A4');
insert into student values ('B1809770', 'Phan Minh J', '2000-10-10', 'DI18V7A4');




insert into teacher values ('B1809811', 'Quach Long Ky Vuong', '2000-02-12');
insert into teacher values ('B1809812', 'Do Boi Anh', '2000-10-15');
insert into teacher values ('B1809813', 'Phan Hoang Anh', '2000-03-01');
insert into teacher values ('B1809814', 'Phan Minh Duc', '2000-05-17');

insert into subj  values ('CT201','.Net');
insert into subj  values ('CT202','Android');
insert into subj  values ('CT203','Python');
insert into subj  values ('CT301','JAVA');
insert into subj  values ('CT302','Machine Learning');
insert into subj  values ('CT303','Web Programing');
insert into subj  values ('CT401','Human–Computer Interaction');
insert into subj  values ('CT402','Object-Oriented Programming');
insert into subj  values ('CT404','Cloud Computing');

insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT201', 'B1809711', 'B1809811', 8);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT201', 'B1809721', 'B1809811', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT201', 'B1809731', 'B1809811', 5);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT201', 'B1809741', 'B1809811', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT201', 'B1809751', 'B1809811', 10);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT201', 'B1809761', 'B1809811', 9);



insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT202', 'B1809712', 'B1809812', 8);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT202', 'B1809722', 'B1809812', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT202', 'B1809732', 'B1809812', 5);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT202', 'B1809742', 'B1809812', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT202', 'B1809752', 'B1809812', 10);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT202', 'B1809762', 'B1809812', 9);



insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT203', 'B1809713', 'B1809813', 8);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT203', 'B1809723', 'B1809813', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT203', 'B1809733', 'B1809813', 5);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT203', 'B1809743', 'B1809813', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT203', 'B1809753', 'B1809813', 10);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT203', 'B1809763', 'B1809813', 9);


insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809714', 'B1809814', 8);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809724', 'B1809814', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809734', 'B1809814', 5);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809744', 'B1809814', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809754', 'B1809814', 10);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809764', 'B1809814', 9);


insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809715', 'B1809811', 8);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809725', 'B1809811', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809735', 'B1809811', 5);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809745', 'B1809811', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809755', 'B1809811', 10);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT301', 'B1809765', 'B1809811', 9);


insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809716', 'B1809812', 8);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809726', 'B1809812', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809736', 'B1809812', 5);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809746', 'B1809812', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809756', 'B1809812', 10);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809766', 'B1809812', 9);



insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809717', 'B1809813', 8);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809727', 'B1809813', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809737', 'B1809813', 5);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809747', 'B1809813', 9);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809757', 'B1809813', 10);
insert into transcript (transcript_subj, transcript_student, transcript_teacher, transcript_point) values ('CT302', 'B1809767', 'B1809813', 9);



