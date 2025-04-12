public class Solution {
    public double AngleClock(int hour, int minutes) {
            double minute_angle = minutes * 6;
    double hour_angle = (hour % 12) * 30 + minutes * 0.5;
    double angle = Math.Abs(hour_angle - minute_angle);
    return Math.Min(angle, 360 - angle);
    }
}