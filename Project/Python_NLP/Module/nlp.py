# build file 종속성 해결 전까지 custom 하여 사용하기

def tokenizer(string):

    lines = string.splitlines() # 문자열을 줄바꿈 기준으로 split # string의 list를 반환
    # string : str, lines : strList

    words = [word for line in lines for word in line.split(' ')] # 각각의 line들을 다시 띄어쓰기 단위로 split
    '''
    words = []
    for line in lines:
        for word in line.split(' '):
            words.append(word)
    '''
    # lines : strList, line : str, line.split(' ') : strList, word : str, words : strList
    
    tokens = [word.strip(' .,?!()"') for word in words] # 각각의 word 들의 구두점을 제외하여 token으로 만듭니다.
    '''
    tokens = []
    for word in words:
        token = word.strip(' .,?!()"')
        tokens.append(token)
    '''
    # words : strList, word : str, word.strip() : str
    
    return tokens

def cleaning(string):
    # TODO
    result = []
    return result

def normalization(string):
    # TODO
    result = []
    return result

def lemmatization(string):
    # TODO
    result = []
    return result

def stemming(string):
    # TODO
    result = []
    return result

def stopword(string, stopwords):
    # TODO
    result = []
    return result

def pos_tagging(string):
    # TODO
    result = []
    return result

def vectorization(string):
    #One-hot Vectorization
    #Bag-of-words Vectorization
    #Hit, Count, and TF-IDF
    #word2vec
    result = []
    return result