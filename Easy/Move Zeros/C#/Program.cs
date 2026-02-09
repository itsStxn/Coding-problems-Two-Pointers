using Move_Zeroes;

var task = new Solution();
int[] test1 = [0,1,0,3,12];
int[] test2 = [0];
task.MoveZeroes(nums: test1);
task.MoveZeroes(nums: [0]);
Console.WriteLine(string.Join(", ", test1));
Console.WriteLine(string.Join(", ", test2));

task = new AlternativeSolution();
test1 = [0,1,0,3,12];
test2 = [0];
task.MoveZeroes(nums: test1);
task.MoveZeroes(nums: [0]);
Console.WriteLine(string.Join(", ", test1));
Console.WriteLine(string.Join(", ", test2));
