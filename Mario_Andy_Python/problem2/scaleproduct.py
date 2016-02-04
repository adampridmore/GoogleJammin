'''
Created on 3 Feb 2016

@author: Mario Herrera
'''
def minimumscaleofproduct(list1,list2):
    list1.sort()
    list2.sort(reverse=True)
    return sum([x*y  for x,y in zip(list1,list2)])




if __name__ == '__main__':
    with open('scalarProduct.txt') as f:
        cases = int(f.readline().strip())
        for counter in xrange(1,cases+1):
            f.readline().strip()
            list1 = map(int, f.readline().strip().split(' '))
            list2 = map(int, f.readline().strip().split(' '))

            print 'Case #' + str(counter) + ': ' + str(minimumscaleofproduct(list1, list2))
