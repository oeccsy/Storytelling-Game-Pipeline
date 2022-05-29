from sklearn import (feature_extraction, linear_model, naive_bayes, neural_network, neighbors, svm, tree, ensemble)
# from nltk import *

traningmodels = [
{'name': 'linear_model.SGD', 'obj': linear_model.SGDClassifier()},
{'name': 'naive_bayes.Gaussian', 'obj': naive_bayes.GaussianNB()},
{'name': 'neural_network.MLP', 'obj': neural_network.MLPClassifier()},
{'name': 'neighbors.KNN', 'obj': neighbors.KNeighborsClassifier()},
{'name': 'svm.LinearSVC', 'obj': svm.LinearSVC()},
{'name': 'svm.SVC(linear)', 'obj': svm.SVC(kernel='linear')},
{'name': 'svm.SVC(poly,2)', 'obj': svm.SVC(kernel='poly', degree=2)},
{'name': 'svm.SVC(poly,3)', 'obj': svm.SVC(kernel='poly')},
{'name': 'svm.SVC(poly,4)', 'obj': svm.SVC(kernel='poly', degree=4)},
{'name': 'svm.SVC(rbf)', 'obj': svm.SVC(kernel='rbf')},
{'name': 'svm.SVC(rbf,$\gamma$=1)', 'obj': svm.SVC(kernel='rbf', gamma=1)},
{'name': 'svm.SVC(rbf,$\gamma$=4)', 'obj': svm.SVC(kernel='rbf', gamma=4)},
{'name': 'svm.SVC(rbf,$\gamma$=16)', 'obj': svm.SVC(kernel='rbf', gamma=16)},
{'name': 'svm.SVC(rbf,$\gamma$=64)', 'obj': svm.SVC(kernel='rbf', gamma=64)},
{'name': 'svm.SVC(sigmoid)', 'obj': svm.SVC(kernel='sigmoid')},
{'name': 'tree.DecisionTree(2)', 'obj': tree.DecisionTreeClassifier(max_depth=2)},
{'name': 'tree.DecisionTree(4)', 'obj': tree.DecisionTreeClassifier(max_depth=4)},
{'name': 'tree.DecisionTree(N)', 'obj': tree.DecisionTreeClassifier()},
{'name': 'tree.ExtraTree', 'obj': tree.ExtraTreeClassifier()},
{'name': 'ensemble.RandomForest(10)', 'obj': ensemble.RandomForestClassifier(n_estimators=10)},
{'name': 'ensemble.RandomForest(100)', 'obj': ensemble.RandomForestClassifier()},
{'name': 'ensemble.ExtraTrees(10)', 'obj': ensemble.ExtraTreesClassifier()},
{'name': 'ensemble.ExtraTrees(100)', 'obj': ensemble.ExtraTreesClassifier()},
{'name': 'ensemble.AdaBoost(DTree)', 'obj': ensemble.AdaBoostClassifier(tree.DecisionTreeClassifier())},
]

vectorizer = [
{'name': 'count', 'vectorizer': feature_extraction.text.CountVectorizer},
{'name': 'hashing', 'vectorizer': feature_extraction.text.HashingVectorizer},
{'name': 'tfid', 'vectorizer': feature_extraction.text.TfidfVectorizer}
]


# build file 종속성 문제로 작성 중단
'''
tokenizers = [
{'name': 'NLTK whitespace', 'tokenizer': nltk.tokenize.WhitespaceTokenizer().tokenize},
{'name': 'NLTK recommended', 'tokenizer': nltk.tokenize.word_tokenize},
{'name': 'NLTK sentence', 'tokenizer': nltk.tokenize.sent_tokenize},
{'name': 'TorchText-None', 'tokenizer': torchtext.data.utils.get_tokenizer(None)},
{'name': 'TorchText-basic', 'tokenizer': torchtext.data.utils.get_tokenizer('basic_english')},
{'name': 'TorchText-spacy', 'tokenizer': torchtext.data.utils.get_tokenizer('spacy')},
{'name': 'KoNLPy Hannanum', 'tokenizer': konlpy.tag.Hannanum().morphs},
{'name': 'KoNLPy Kokoma', 'tokenizer': konlpy.tag.Kkma().morphs},
{'name': 'KoNLPy Komoran', 'tokenizer': konlpy.tag.Komoran().morphs},
{'name': 'KoNLPy OpenKoreanText', 'tokenizer': konlpy.tag.Okt().morphs}
'''