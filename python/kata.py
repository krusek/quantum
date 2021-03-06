from basic_gates import BasicGatesTest
from superposition import SuperpositionTest
from measurements import MeasurementTest
from joint_measurements import JointMeasurementTest

if __name__ == '__main__':
  BasicGatesTest().run_all_tests()
  SuperpositionTest().run_all_tests()
  MeasurementTest().run_all_tests()
  JointMeasurementTest().run_all_tests()