# -*- coding: utf-8 -*-
"""
Created on Mon Apr 25 01:55:11 2022

@author: jm_vi
"""

import psycopg2 as pc

conexion = pc.connect(user="postgres",
                      password="1998",
                      host="127.0.0.1",
                      port="5432",
                      database="mibasejhulen")

bd = conexion.cursor()
#sql="select * from persona"
sql="select avg(case when departamento='02' then notafinal end) LP, avg(case when departamento='03' then notafinal end) CB, avg(case when departamento='06' then notafinal end) TR, avg(case when departamento='05' then notafinal end) PT,avg(case when departamento='07' then notafinal end) ST from persona p, inscripcion i where i.ciestudiante=p.ci;"

bd.execute(sql)

for lp, cb, tr, pt, st in bd.fetchall() :
    print (lp, cb, tr, pt, st)

conexion.commit()
conexion.close()
