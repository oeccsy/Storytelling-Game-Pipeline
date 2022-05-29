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