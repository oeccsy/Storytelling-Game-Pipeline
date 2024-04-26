import pymysql

db = None

db_info_path = "db_info.txt"
db_info = {}

with open(db_info_path, 'r') as file:
  key_list = ['user', 'passwd', 'db']
  
  for data, key in zip(file, key_list):
    db_info[key] = data

try:
  db = pymysql.connect(
    host = '127.0.0.1',
    user = 'homestead',
    passwd = 'secret',
    db = 'homestead',
    charset = 'utf8'
  )
  print("DB 연결 성공")
  
except Exception as e:
  print(e)

finally:
  if db is not None:
    db.close()
    print("DB 닫기 성공")