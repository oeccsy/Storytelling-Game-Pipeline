import sys
import os
sys.path.append(os.path.dirname(os.path.abspath(os.path.dirname(__file__))))

import sklearn
import sklearn.feature_extraction
import sklearn.linear_model
from Module import *

csv_traning = data_traning()
csv_predict = data_predict()
csv_test = data_test()

lines = csv_traning.splitlines()

data = []
target = []
input = []

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
input.append(csv_predict)

model = train(data, target)
pred = predict(model, input)

result = pred[0]
print(result)