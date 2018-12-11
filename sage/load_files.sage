import os

def load_files(files):
  path = os.getcwd()
  p = path
  while "sage" in p and p.endswith("sage") == False:
    os.chdir("../")
    p = os.getcwd()
  for file in files:
    load(file)
  os.chdir(path)