def reverseWords(input):
    return ' '.join(input.split(' ')[::-1])


if __name__ == "__main__":
    #import sys;sys.argv = ['', 'Test.testName']
    
    with open('reverseWords.txt') as f:
        lines = int(f.readline().strip())
        for counter in xrange(1,lines+1):
            print 'Case #' + str(counter) + ': ' + reverseWords(f.readline().strip())
            