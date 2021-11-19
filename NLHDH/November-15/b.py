import pathlib

p = pathlib.Path('./November-15/*.py')
for name in p.glob('[a-d]*.txt'):
  print(name)
# dir1
# dir2
# address.txt

for name in p.glob('./November-15/????.txt'):
    print(name)
# pass.txt
# user.txt
