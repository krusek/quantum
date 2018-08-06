def norm(v):
  return sqrt(v[0]*conjugate(v[0])+v[1]*conjugate(v[1]))

def bloch(v):
  n = norm(v)
  vv = [v[0]/n, v[1]/n]
  vv = [abs(vv[0]), abs(vv[0])*vv[1]/vv[0]]
  print(vv)
  theta = pi/2 if vv[0] == 1/sqrt(2) else (arccos(vv[0]) * 2)

  phi = ln(vv[1]/sin(theta/2))/i if vv[1] != 0 else 0
  return [cos(phi)*sin(theta),sin(phi)*sin(theta), cos(theta)]

def Rx(theta):
  return matrix([[cos(theta/2), -i*sin(theta/2)],[-i*sin(theta/2),cos(theta/2)]])

def Rz(theta):
  return matrix([[exp(-i*theta/2), 0], [0, exp(i*theta/2)]])

def Sx():
  return matrix([[0,1],[1,0]])

def Sy():
  return matrix([[0,-i],[i,0]])

def Sz():
  return matrix([[1,0],[0,-1]])

def Rn(n, theta):
  return matrix([[1,0],[0,1]])*cos(theta/2)-i*sin(theta/2)*(n[0]*Sx()+n[1]*Sy()+n[2]*Sz())
