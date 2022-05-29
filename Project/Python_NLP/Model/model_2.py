import sklearn
import sklearn.feature_extraction
import sklearn.linear_model

def train(dataset, target):

    vectorizer = sklearn.feature_extraction.text.TfidfVectorizer()
    vector = vectorizer.fit_transform(dataset)

    classifier = sklearn.linear_model.SGDClassifier()
    classifier.fit(vector, target)
    return (vectorizer, classifier)


def predict(model, dataset):

    vectorizer, classifier = model
    vector = vectorizer.transform(dataset)
    pred = classifier.predict(vector)
    return pred


csv = open("./test.txt", 'r', encoding="utf-8").read()
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

model = train(data, target)
pred = predict(model, test)
accuracy = sklearn.metrics.balanced_accuracy_score(test_target, pred)

print(pred)
print(accuracy)