# -*- coding: utf-8 -*-
"""
Created on Mon Apr 25 02:40:00 2022

@author: jm_vi
"""
import pymysql

miConexion = pymysql.connect( host='localhost', user= 'examen324', passwd='123456', db='mibasejhulen' )
cur = miConexion.cursor()
cur.execute( "SELECT ci FROM persona" )
cur.execute("select avg(case when departamento='02' then notafinal end) LP, "
            +"avg(case when departamento='03' then notafinal end) CB, "
            +"avg(case when departamento='06' then notafinal end) TR, "
            +"avg(case when departamento='05' then notafinal end) PT,"
            +"avg(case when departamento='07' then notafinal end) ST "
            +"from persona p, inscripcion i where i.ciestudiante=p.ci;")
for dep in cur.fetchall() :
    print ( dep)
miConexion.close()