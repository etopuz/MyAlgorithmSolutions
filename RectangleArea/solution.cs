public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int xL = ax1 > bx1 ? ax1 : bx1;
        int yL = ay1 > by1 ? ay1 : by1;
        int xR = ax2 < bx2 ? ax2 : bx2;
        int yR = ay2 < by2 ? ay2 : by2;
        Console.WriteLine(xL + " " + yL + " " + xR + " " + yR);
        int intersection = ((yR-yL) > 0 && (xR- xL)>0) ? (yR-yL) * (xR- xL):0;
        int reca = (ax2-ax1) * (ay2-ay1);
        int recb = (bx2-bx1) * (by2-by1);
        return reca + recb - intersection;
    }
}