import pymysql

def select_from_db(sql):
    rows=[]
    conn = pymysql.connect(
        host='localhost',
        user='root',
        password='toor',
        db='napelem',
        charset='utf8mb4',
        cursorclass=pymysql.cursors.DictCursor
    )

    try:
        with conn.cursor() as cursor:
            
            #sql = "SELECT * FROM `alkatresz`"
            cursor.execute(sql)
            rows = cursor.fetchall()
    except:
            return "hiba a csatlakozás során"
    finally:
        conn.close()
    if len(rows)!=0:
        response=""
        for row in rows:
            for tul in row:
                response+=f"\"{tul}\":\"{row[tul]}\","
            response=response[0:len(response)-1]
            response+="#"
        response=response[0:len(response)-1]
        #print(response)
        return response
    else:
        return "hibás felhasználónév vagy jelszó"

def nonselect_db_command(sql):
    conn = pymysql.connect(
        host='localhost',
        user='root',
        password='toor',
        db='napelem',
        charset='utf8mb4',
        cursorclass=pymysql.cursors.DictCursor
    )
    try:
        with conn.cursor() as cursor:
            
            cursor.execute(sql)
    except:
            return "hiba"
    finally:
        conn.close()
    return "done"


print(select_from_db("SELECT tipus_id,tipus,ar,SUM(rekesz.mennyi)AS darabszám from alkatresz join rekesz on alkatresz.tipus_id = rekesz.alkatresz_id group by tipus"))

#print(select_from_db("Select rendeles.rendeles_id,rendeles.projekt_id,alkatresz.tipus,rendeles.mennyiseg,rendeles_allapot.allapot_nev from rendeles join rendeles_allapot on rendeles.rendeles_allapot = rendeles_allapot.allapot_id join alkatresz on rendeles.alkatresz = alkatresz.tipus_id"))