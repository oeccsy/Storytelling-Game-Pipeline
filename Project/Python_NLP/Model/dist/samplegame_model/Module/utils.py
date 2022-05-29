import sys
import os

def print_path():
    print(__file__)
    print(os.getcwd())

def data_traning():
    return open("./Data/data_traning.txt", 'r', encoding="utf-8").read()

def data_predict():
    return open("./Data/data_predict.txt", 'r', encoding="utf-8").read()

def data_test():
    return open("./Data/data_test.txt", 'r', encoding="utf-8").read()