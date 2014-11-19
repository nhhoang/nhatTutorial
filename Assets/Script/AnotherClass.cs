using UnityEngine;
using System.Collections;

public class AnotherClass {
	public int apples;
	public int bananas;

	private int stapler;
	private int sellotape;

	public void FruitMachine(int a, int b)
    {
    	int answer;
    	answer = a + b;
    	Debug.Log("Fruit total: " + answer + " a= " + a + " b= " + b);
    }

  public static void FruitMachineStatic(int a, int b)
    {
    	int answer;
    	answer = a + b;
    	Debug.Log("Fruit total: " + answer + " a= " + a + " b= " + b);
    }

  private void OfficeSort(int a, int b) {
  	int answer;
  	answer = a + b;
  	Debug.Log("Office Supplies total: " + answer);
  }
}
