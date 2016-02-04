'''
Created on 3 Feb 2016

@author: Mario Herrera
'''
import unittest

from directory import Directory, countNewFolders

class Test(unittest.TestCase):

    def testcase1(self):
        rootFolder = Directory()
        folderNames = '/home/gcj/finals'
        rootFolder.addDirectory(folderNames.split('/')[1:])
        self.assertEqual(3, rootFolder.size())
        folderNames = '/home/gcj/quals'
        rootFolder.addDirectory(folderNames.split('/')[1:])
        self.assertEqual(4, rootFolder.size())
        
    def testcase2(self):
        self.assertEqual(0, countNewFolders(['/chicken', '/chicken/egg'], ['/chicken']))

    def testcase3(self):
        self.assertEqual(4, countNewFolders(['/a'], ['/a/b','/a/c','/b/b']))


if __name__ == "__main__":
    #import sys;sys.argv = ['', 'Test.testcase1']
    unittest.main()