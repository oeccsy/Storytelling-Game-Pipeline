import pandas as pd
import matplotlib.pyplot as plt
import urllib.request
from gensim.models.word2vec import Word2Vec
from konlpy.tag import Okt

urllib.request.urlretrieve("https://raw.githubusercontent.com/e9t/nsmc/master/ratings.txt", filename="ratings.txt")
train_data = pd.read_table('ratings.txt')
print("====데이터 출력====")
print(train_data[:5])

print("====데이터 갯수 출력====")
print(len(train_data))

print("====Null 값 존재 유무 출력====")
print(train_data.isnull().values.any())

print("====Null 값 존재하는 행 제거====")
train_data = train_data.dropna(how = 'any')
print(train_data.isnull().values.any())

print("====Null 값 제거 이후 데이터 갯수 출력====")
print(len(train_data))

print("====데이터 갯수 조정====")
train_data = train_data[:5000]
print(len(train_data))

print("====데이터 전처리====")
train_data['document'] = train_data['document'].str.replace("[^ㄱ-ㅎㅏ-ㅣ가-힣 ]","", regex=True)
print(train_data[:5])

# 불용어 정의
stopwords = ['의','가','이','은','들','는','좀','잘','걍','과','도','를','으로','자','에','와','한','하다']

# 형태소 분석기 OKT를 사용한 토큰화 작업
okt = Okt()
tokenized_data = []
for sentence in train_data['document']:
    tokenized_sentence = okt.morphs(sentence, stem=True) # 토큰화
    stopwords_removed_sentence = [word for word in tokenized_sentence if not word in stopwords] # 불용어 제거
    tokenized_data.append(stopwords_removed_sentence)

print("====토큰화 이후 데이터 출력====")
tokenized_data[:5]

# 리뷰 길이 분포 확인
print('리뷰의 최대 길이 :',max(len(review) for review in tokenized_data))
print('리뷰의 평균 길이 :',sum(map(len, tokenized_data))/len(tokenized_data))
plt.hist([len(review) for review in tokenized_data], bins=50)
plt.xlabel('length of samples')
plt.ylabel('number of samples')
plt.show()

# word embedding
model = Word2Vec(sentences = tokenized_data, vector_size = 100, window = 5, min_count = 5, workers = 4, sg = 0)

print("====임베딩 이후 매트릭스 크기 출력====")
print(model.wv.vectors.shape)

print("====히어로와 비슷한 단어 출력====")
print(model.wv.most_similar("히어로"))
