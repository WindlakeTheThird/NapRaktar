
import threading
import socket
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
        print(response)
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
    #conn.autocommit(True)
    try:
        with conn.cursor() as cursor:
            
            #sql = "SELECT * FROM `alkatresz`"
            cursor.execute(sql)    
            conn.commit()   
    except:
        return "hiba a csatlakozás során"
    finally:
        conn.close()
        return "done"

HOST = "127.0.0.1"  # Standard loopback interface address (localhost)
PORT = 65432  # Port to listen on (non-privileged ports are > 1023)

s= socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind((HOST, PORT))

def handle_client_select(conn, addr,sql):
    
    print(f"[NEW CONNECTION] {addr} connected.")
    conn.send(bytes(select_from_db(sql).encode('utf-8')))

def handle_client_nonnselect(conn, addr,sql):
    
    print(f"[NEW CONNECTION] {addr} connected.")
    conn.send(bytes(nonselect_db_command(sql).encode('utf-8')))
    

def start():
    s.listen(5)
    print(f"[LISTENING] Server is listening on {socket.gethostname()}")
    while True:
        connect_to_socket,addr=s.accept()
        got_the_name = False
        clienmsg = str(connect_to_socket.recv(16000))
        sql=clienmsg.split('#')[1].rstrip(clienmsg.split('#')[1][-1])
        print(clienmsg.split('#')[0][-1])
        if(clienmsg.split('#')[0][-1] == '1'):
            print(sql)
            thread = threading.Thread(target=handle_client_select, args=(connect_to_socket, addr,sql))
            thread.start()
        else:
            print(sql)
            thread = threading.Thread(target=handle_client_nonnselect, args=(connect_to_socket, addr,sql))
            thread.start()
        
        print(f"[ACTIVE CONNECTIONS] {threading.active_count() - 1}")

print("[STARTING] server is starting...")
start()