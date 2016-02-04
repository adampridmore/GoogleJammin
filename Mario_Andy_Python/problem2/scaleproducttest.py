'''
Created on 3 Feb 2016

@author: Mario Herrera
'''
import unittest
from scaleproduct import minimumscaleofproduct

class Test(unittest.TestCase):


    def testtest1(self):
        self.assertEqual(-25, minimumscaleofproduct([1,3,-5], [-2,4,1]))
    def testtest2(self):
        self.assertEqual(6, minimumscaleofproduct([1,2,3,4,5], [1,0,1,0,1]))

if __name__ == "__main__":
    #import sys;sys.argv = ['', 'Test.testtest1']
    unittest.main()