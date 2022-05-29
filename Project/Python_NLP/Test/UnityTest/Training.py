iris = open("Assets/Scripts/Python/Test/test.data", 'r', encoding="utf-8").read()
lines = iris.splitlines()

data = []
target = []

for line in lines:
    line = line.split(',')

    if line == ['']:
        break
    newdata = line[0]
    newtarget = line[1]
    if newtarget == "Test":
        newtarget = 0
    if newtarget == "Iris-versicolor":
        newtarget = 1
    if newtarget == "Iris-virginica":
        newtarget = 2
    data.append(newdata)
    target.append(newtarget)

print(data)
print(target)