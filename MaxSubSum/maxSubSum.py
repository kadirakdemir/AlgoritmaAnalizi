def maxSubSum1(array):
    maxSum=0
    for i in range(0,len(array)):
        for j in range(i,len(array)):
            thisSum=0
            for k in range(i,j):
                thisSum=thisSum+array[k]
            if(thisSum>maxSum):
                maxSum=thisSum
    return maxSum
def maxSubSum2(array):
    maxSum1=0
    for i in range(0,len(array)):
        thisSum1=0
        for j in range(i,len(array)):
            thisSum1=thisSum1+array[j]
        if(thisSum1>maxSum1):
                maxSum1=thisSum1
    return maxSum1

array=[4,-30,5,-2,-1,2,6,-2]
size=int(input("dizinin boyutu ne olsun"))
array1=[]
import random
for i in range(0,size):
    array1.append(random.randint(-10,10))

print("dizinin boyutu : ",len(array1))
print("dizinin elemanları ")
for i in range(0,size):
    print(i,".  ",array1[i])
    
import time
start_time1=time.time()
print("maxSubSum2 sonucu :", maxSubSum2(array1))
print("gecen süre : ", time.time()-start_time1)

start_time2=time.time()
print("maxSubSum1 sonucu :", maxSubSum1(array1))
print("gecen süre : ", time.time()-start_time2)