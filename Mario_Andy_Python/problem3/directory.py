'''
Created on 3 Feb 2016

@author: Mario Herrera
'''
class Directory():
    
    def __init__(self):
        self.children = {}
        
    def size(self):
        return len(self.children) + sum([child.size() for child in self.children.itervalues() ])

    def addDirectory(self, folderNames):
        folderName = folderNames[0]
        if not folderName in self.children:
            self.children[folderName] = Directory()
        if len(folderNames) > 1:
            self.children[folderName].addDirectory(folderNames[1:])
        
def countNewFolders(existingFolders, newFolders):
    rootFolder = Directory()
    for folder in existingFolders:
        rootFolder.addDirectory(folder.split('/')[1:])
    existingCount = rootFolder.size()
    for folder in newFolders:
        rootFolder.addDirectory(folder.split('/')[1:])
    return rootFolder.size() - existingCount
        
if __name__ == '__main__':
    root = Directory()
    root.addDirectory(['home', 'gcj', 'finals'])
    root.addDirectory(['home', 'gcj', 'quals'])
    print root.size()