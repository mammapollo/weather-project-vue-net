import { AstronomyModelResponse } from "./astronomy.model.response";
import { RealTimeModelResponse } from "./realtime.model.response";
import { TimeZoneModelResponse } from "./timezone.response.model";

export default interface ResponseData {
  astronomyModelResponse: AstronomyModelResponse;
  realTimeModelResponse: RealTimeModelResponse;
  timeZoneModelResponse: TimeZoneModelResponse;
}