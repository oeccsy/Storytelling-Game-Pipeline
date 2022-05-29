import sys
import os
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))

import sklearn
import Module.ml
import Module.nlp
import Module.utils


# csv = open("../../Python_NLPAssets/Scripts/Python/Test/test.txt", 'r', encoding="utf-8").read()
csv = open("../../Python_NLP/Data/test.txt", 'r', encoding="utf-8").read()
#csv = open("../Data/test.txt", 'r', encoding="utf-8").read()
lines = csv.splitlines()

data = []
target = []

test = ['나는 호랑이 옆에 있다', '동물원 안에 호랑이가 있다', '야호 오늘은 호랑이를 만났다']
test_target = [2, 2, 1]

for line in lines:
    line = line.split(',')

    if line == ['']:
        break

    newdata = line[0]
    newtarget = line[1]

    if newtarget == "None":
        newtarget = 0
    if newtarget == "Happy":
        newtarget = 1
    if newtarget == "Sad":
        newtarget = 2

    data.append(newdata)
    target.append(newtarget)

model = Module.ml.train(data, target)
pred = Module.ml.predict(model, test)
accuracy = sklearn.metrics.balanced_accuracy_score(test_target, pred)

print(pred)
print(accuracy)