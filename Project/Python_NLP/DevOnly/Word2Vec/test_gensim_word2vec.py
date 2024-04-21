from gensim.models import Word2Vec
from gensim.test.utils import common_texts

# 예제 텍스트 데이터
sentences = common_texts
print("데이터 갯수 출력")
print(len(sentences))

for sentence in sentences:
    print(sentence)

# Word2Vec 모델 학습
model = Word2Vec(sentences, vector_size=100, window=5, min_count=1, workers=4)

# 단어 벡터 추출
word_vectors = model.wv

# 단어 벡터 확인
vector = word_vectors['computer']
print("단어 'computer'의 벡터:", vector)

# 가장 유사한 단어 찾기
similar_words = word_vectors.most_similar('computer', topn=5)
print("단어 'computer'와 유사한 단어들:", similar_words)
