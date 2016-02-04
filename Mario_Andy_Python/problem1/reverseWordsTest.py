'''
Created on 3 Feb 2016

@author: Andy
'''
import unittest

from reverseWords import reverseWords

class ReverseWordsTest(unittest.TestCase):

    def testSample1(self):
        self.assertEquals(reverseWords('this is a test'),'test a is this')

    def testSample2(self):
        self.assertEquals(reverseWords('foobar'),'foobar')

    def testSample3(self):
        self.assertEquals(reverseWords('all your base'),'base your all')

if __name__ == "__main__":
    #import sys;sys.argv = ['', 'Test.testName']
    unittest.main()